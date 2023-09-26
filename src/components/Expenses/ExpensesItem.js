import ExpenseDate from "./ExpenseDate";

const ExpensesItem = (props) =>{
    
return(
    <div className="inline-grid grid-cols-3 gap-4 p-6 m-3 bg-white border border-gray-200 rounded-lg shadow hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-700 dark:hover:bg-gray-700">
        <div>
            <ExpenseDate date={props.date} />
        </div>
        <div className="w-full">{props.title}</div>
        <div>${props.amount}</div>
    </div>
)
}

export default ExpensesItem;