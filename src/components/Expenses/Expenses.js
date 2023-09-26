import ExpensesItem from "./ExpensesItem";

const Expenses = (props) => {
  return (
    <div className="block max-w-sm p-6 bg-white border border-gray-200 rounded-lg shadow hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-700 dark:hover:bg-gray-700">
      <ExpensesItem
        title={props.items[0].title}
        date={props.items[0].date}
        amount={props.items[0].amount}
      />
      <ExpensesItem
        title={props.items[1].title}
        date={props.items[1].date}
        amount={props.items[1].amount}
      />
      <ExpensesItem
        title={props.items[2].title}
        date={props.items[2].date}
        amount={props.items[2].amount}
      />
    </div>
  );
};

export default Expenses;
