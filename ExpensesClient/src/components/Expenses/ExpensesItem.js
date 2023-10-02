import ExpenseDate from "./ExpenseDate";

const ExpensesItem = (props) => {
  
  return (
    <div className="inline-grid grid-cols-3 gap-4 p-6 m-3 bg-purple-100 border border-gray-200 rounded-lg shadow hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-700 dark:hover:bg-gray-700">
      <ExpenseDate date={props.date} />
      <span className="inline-block align-middle">{props.title}</span>
      <span className="font-bold">${props.amount}</span>
    </div>
  );
};

export default ExpensesItem;
