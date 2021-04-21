function ShowExpenseInput(budgetId) {
    //show input panel
    $("#ExpensePanel").slideDown();
    //Set Id so we know what budget to update
    $("#ExpensePanelId").val(budgetId);
    //Get and set the currency
    $("#ExpenseCurrencyDisplay").text($("#Currency-" + budgetId).val());
    //Set to the correct Currency
    $("#ExpenseCurrency").val(currency);
    //Clear existing data
    //---
    //---To DO
    //---
}

$("#AddExpenseSubmit").click(function () {
    var id = $("#ExpensePanelId").val();
    var currency = $("#ExpenseCurrency").val();
    $("#ExpenseCurrencyDisplay").val(currency);
    console.log("updating budget " + id);
    //do Ajax postback
    //reset id to empty so it can't be accidentally re-used
    $("#ExpensePanelId").val('');
    //Hide input panel
    $("#ExpensePanel").hide();
});

$("#ExpenseDistribute").click(function () {
    $("#ExpenseDistributePanel").slideToggle();
});


$("#CancelExpense").click(function () {
    $("#ExpenseDistributePanel").hide();
    $("#ExpensePanel").slideUp();
})