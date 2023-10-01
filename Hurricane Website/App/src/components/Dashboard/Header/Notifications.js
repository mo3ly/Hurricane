import Dropdown from '@/components/Dropdown/Dropdown'
import {
    DropdownButton,
    DropdownItem,
} from '@/components/Dropdown/DropdownLink'
import { HiChatAlt2 } from 'react-icons/hi'

function Notifications() {
    return (
        <div className="relative inline-flex ml-3">
            <Dropdown
                align="right"
                width="60"
                trigger={
                    <button className="flex items-center text-sm font-medium text-gray-500 hover:text-gray-700 focus:outline-none transition duration-150 ease-in-out">
                        <div className="w-8 h-8 bg-gray-200 text-hurricane-gray flex items-center justify-center rounded-full mr-2">
                            <HiChatAlt2 className="w-6 h-6" />
                        </div>

                        <span className="sr-only">Notifications</span>
                        <div className="absolute top-0 right-2 w-2.5 h-2.5 bg-rose-500 border-2 border-white rounded-full"></div>
                    </button>
                }>
                <DropdownItem>
                    <div className="text-xs font-semibold tracking-wider text-white bg-hurricane-gray uppercase pt-1.5 pb-2 px-4">
                        Notifications
                    </div>
                </DropdownItem>
                <DropdownButton>
                    <div className="border-b pb-2">
                        <span className="block text-sm mb-2">
                            <div>
                                📣
                                <span className="ml-1 font-semibold text-hurricane-gray">
                                    Welcome to our service
                                </span>
                            </div>
                            <p>
                                We would like to thank you for choosing our
                                service.
                            </p>
                        </span>
                        <span className="block text-xs font-medium text-slate-400">
                            Feb 12, 2021
                        </span>
                    </div>
                </DropdownButton>
            </Dropdown>
        </div>
    )
}

export default Notifications
