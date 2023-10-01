using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PusherClient;

namespace HurricaneServiceManager.Logic
{
    sealed class PusherConnection
    {
        public string Host { get; private set; }

        public string Port { get; private set; }

        public string Key { get; private set; }

        public bool isConnected  { get; private set; } = false;

        private Pusher pusher = null;

        private Channel serviceManagerChannel = null;


        public PusherConnection (string host, string port, string key)
        {
            Host = host;
            Port = port;
            Key = key;
            Instance();
        }

        private void Instance()
        {
            if(pusher == null)
            {
                pusher = new Pusher(Key, new PusherOptions
                {
                    Host = Host + ":" + Port,
                    ClientTimeout = TimeSpan.FromMinutes(20)
                });
                pusher.ConnectionStateChanged += StateChanged;
                pusher.Connected += OnConnected;
                pusher.Disconnected += OnDisconnected;
                pusher.Error += ErrorHandler;

            }
        }

        void StateChanged(object sender, ConnectionState state)
        {
            Global.Dashboard.WriteLog("Pusher connection state: " + state.ToString());
        }

        void ErrorHandler(object sender, PusherException error)
        {
            Global.Dashboard.WriteLog("Pusher error: " + error.ToString(), 0);
        }

        void OnConnected(object sender)
        {
            Console.WriteLine("Connection to pusher has been established successfully. SocketID: " + ((Pusher)sender).SocketID, 1);
        }

        void OnDisconnected(object sender)
        {
            Console.WriteLine("Disconnected from pusher server. SocketID: " + ((Pusher)sender).SocketID, 1);
        }

        public async Task<bool> Connect()
        {
            if (pusher == null)
                return false;

            if (!isConnected)
            {
                try
                {
                    await pusher.ConnectAsync().ConfigureAwait(false);
                    return isConnected = true;
                } 
                catch (Exception e)
                {
                    Global.Dashboard.WriteLog("An error occured while connecting to pusher. Error: " + e.Message, 0);
                    return isConnected = false;
                }
            } else
            {
                return true;
            }
        }

        public async Task<bool> Disconnect()
        {
            if (isConnected)
            {
                try
                {
                    await pusher.DisconnectAsync().ConfigureAwait(false);
                    Global.Dashboard.WriteLog("Disconnected the pusher client.", 0);
                    isConnected = false;
                    return true;
                }
                catch (Exception e)
                {
                    Global.Dashboard.WriteLog("An error occured while disconnecting the pusher client. Error: " + e.Message, 0);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public async Task<bool> SubscribeServiceManagerChannel()
        {
            if (isConnected)
            {
                try
                {
                    serviceManagerChannel = await pusher.SubscribeAsync("service-manager").ConfigureAwait(false);
                    if (serviceManagerChannel.IsSubscribed)
                    {
                        serviceManagerChannel.Bind(PusherEvents.MODULE_SHUTDOWN, (PusherEvent eventResponse) => PusherEventManager.OnEventReceive(PusherEvents.MODULE_SHUTDOWN, eventResponse));
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Global.Dashboard.WriteLog("An error occured while subscribing Service Manager channel. Error: " + e.Message, 0);
                    return false;
                }
            } 
            else
            {
                return false;
            }
        }

        public async void UnsubscribeServiceManagerChannel()
        {
            if (serviceManagerChannel.IsSubscribed)
            {
                try
                {
                    serviceManagerChannel.Unsubscribe();
                }
                catch (Exception e)
                {
                    Global.Dashboard.WriteLog("An error occured while unsubscribing Service Manager channel. Message: " + e.Message, 0);
                }
            }
        }
    }
}
