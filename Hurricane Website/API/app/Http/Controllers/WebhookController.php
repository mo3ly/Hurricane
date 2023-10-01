<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Response;

class WebhookController extends Controller
{
    public function __invoke(Request $request)
    {
        $secret = config("broadcasting.connections.pusher.secret");
        $webhook_signature = $request->header("X_PUSHER_SIGNATURE");
    
        $body = $request->all();
    
        $expected_signature = hash_hmac("sha256", json_encode($body), $secret, false);
        if($webhook_signature == $expected_signature) {

            foreach($body['events'] as $event) {
                $channelToken = explode('.', $event['channel'])[1];
                
                switch($event['name']) {
                    case 'member_added':
                        \Log::info($event);
                        break;
                    case 'member_removed':
                        \Log::info($event);
                        break;
                    case 'channel_occupied':
                        \Log::info($event);
                        break;
                    case 'channel_vacated':
                        \Log::info($event);
                        break;
                    case 'client_event':
                        \Log::info($event);
                        break;
                }

            }

            return Response::json([200]);
        } else {
            return abort(401);
        }
    }
}
