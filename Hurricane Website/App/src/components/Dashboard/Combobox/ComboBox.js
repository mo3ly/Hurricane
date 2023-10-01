import { Fragment, useState } from 'react'
import { Combobox, Transition } from '@headlessui/react'
import { AiOutlineCheck } from 'react-icons/ai'
import { HiSelector } from 'react-icons/hi'

const ComboBox = ({ data }) => {
    const [selected, setSelected] = useState(data[0])
    const [query, setQuery] = useState('')

    const filteredData =
        query === ''
            ? data
            : data.filter(person =>
                  person.name
                      .toLowerCase()
                      .replace(/\s+/g, '')
                      .includes(query.toLowerCase().replace(/\s+/g, '')),
              )

    return (
        <div>
            <Combobox value={selected} onChange={setSelected}>
                <div className="relative mt-1">
                    <div className="relative w-full border py-0.5 cursor-default overflow-hidden bg-white text-left focus:outline-none focus-visible:ring-2 focus-visible:ring-white focus-visible:ring-opacity-75 focus-visible:ring-offset-2 focus-visible:ring-offset-teal-300 sm:text-sm">
                        <Combobox.Input
                            className="w-full border-none py-2 pl-3 pr-10 text-sm leading-5 text-gray-900 focus:ring-0"
                            displayValue={person => person.name}
                            onChange={event => setQuery(event.target.value)}
                        />
                        <Combobox.Button className="absolute inset-y-0 right-0 flex items-center pr-2">
                            <HiSelector
                                className="h-5 w-5 text-gray-400"
                                aria-hidden="true"
                            />
                        </Combobox.Button>
                    </div>
                    <Transition
                        as={Fragment}
                        leave="transition ease-in duration-100"
                        leaveFrom="opacity-100"
                        leaveTo="opacity-0"
                        afterLeave={() => setQuery('')}>
                        <Combobox.Options className="absolute z-20 mt-1 max-h-60 w-full overflow-auto bg-white py-1 text-base shadow-md ring-1 ring-black ring-opacity-5 focus:outline-none sm:text-sm">
                            {filteredData.length === 0 && query !== '' ? (
                                <div className="relative cursor-default select-none py-2 px-4 text-gray-700">
                                    Nothing found.
                                </div>
                            ) : (
                                filteredData.map(person => (
                                    <Combobox.Option
                                        key={person.id}
                                        className={({ active }) =>
                                            `relative cursor-default select-none py-2 pl-10 pr-4 ${
                                                active
                                                    ? ' bg-hurricane-gold text-white'
                                                    : ' text-hurricane-dark-gray '
                                            }`
                                        }
                                        value={person}>
                                        {({ selected, active }) => (
                                            <>
                                                <span
                                                    className={`block truncate ${
                                                        selected
                                                            ? 'font-medium'
                                                            : 'font-normal'
                                                    }`}>
                                                    {person.name}
                                                </span>
                                                {selected ? (
                                                    <span
                                                        className={`absolute inset-y-0 left-0 flex items-center pl-3 ${
                                                            active
                                                                ? 'bg-hurricane-gold'
                                                                : 'text-hurricane-gold'
                                                        }`}>
                                                        <AiOutlineCheck
                                                            className="h-5 w-5"
                                                            aria-hidden="true"
                                                        />
                                                    </span>
                                                ) : null}
                                            </>
                                        )}
                                    </Combobox.Option>
                                ))
                            )}
                        </Combobox.Options>
                    </Transition>
                </div>
            </Combobox>
        </div>
    )
}

export default ComboBox
