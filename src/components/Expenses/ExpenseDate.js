
const ExpenseDate = (props) => {

    const month = props.date.toLocaleString('en-US', {month: 'long'});
    const day = props.date.toLocaleString('en-US', {day: '2-digit'});
    const year = props.date.getFullYear();

    return(
        <div className="block max-w-sm p-2 bg-white border border-gray-200 rounded-lg shadow hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-700 dark:hover:bg-gray-700">
            <div className="text-center">{month}</div>
            <div className="text-center">{year}</div>
            <div className="text-center">{day}</div>
        </div>
    )
}

export default ExpenseDate;