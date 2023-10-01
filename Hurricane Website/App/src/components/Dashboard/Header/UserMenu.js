import { useAuth } from '@/hooks/auth'
import Dropdown from '@/components/Dropdown/Dropdown'
import {
    DropdownButton,
    DropdownItem,
} from '@/components/Dropdown/DropdownLink'
import { BiUserCircle } from 'react-icons/bi'

function UserMenu({ user }) {
    const { logout } = useAuth()

    return (
        <div className="relative inline-flex">
            <Dropdown
                align="right"
                width="52"
                trigger={
                    <button className="flex items-center text-sm font-medium text-gray-500 hover:text-gray-700 focus:outline-none transition duration-150 ease-in-out">
                        <div className="w-8 h-8 bg-hurricane-gray text-white flex items-center justify-center rounded-full mr-2">
                            <BiUserCircle className="w-6 h-6" />
                        </div>
                        <div>{user?.name}</div>

                        <div className="ml-1">
                            <svg
                                className="fill-current h-4 w-4"
                                xmlns="http://www.w3.org/2000/svg"
                                viewBox="0 0 20 20">
                                <path
                                    fillRule="evenodd"
                                    d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"
                                    clipRule="evenodd"
                                />
                            </svg>
                        </div>
                    </button>
                }>
                <DropdownItem>
                    <div className="border-b py-2 flex flex-row">
                        <div>
                            <div className="w-8 h-8 bg-hurricane-gray text-white flex items-center justify-center rounded-full mr-2">
                                <BiUserCircle className="w-6 h-6" />
                            </div>
                        </div>
                        <div>
                            <div className="font-bold"> {user?.name}</div>
                            <div className="text-xs"> {user?.email}</div>
                            <div className="text-xs"> Balance: 0.00$</div>
                        </div>
                    </div>
                </DropdownItem>
                <DropdownButton>Account settings</DropdownButton>
                {/* Authentication */}
                <DropdownButton onClick={logout}>Logout</DropdownButton>
            </Dropdown>
        </div>
    )
}

export default UserMenu
