
function HideAll() {
    $("#Budget-Allowance").hide();
    $("#Budget-Expenditure").hide();
    $("#Budget-Income").hide();
}

function DisplayError(msg) {
    $("#Error").slideDown();
    $("#Error-Message").text(msg);
}

function HideError() {
    $("#Error").hide();
}

$(document).ready(function () {
    HideAll();
    HideError();
    $("#Budget-Allowance").slideToggle();
});

//#region Currency
var Currency;

//Update Currency for the form
function UpdateCurrency() {
    $("#Budget-Expenditure-Currency").text(Currency);
    $("#Budget-Income-Currency").text(Currency);
}
//Set Currency Variable
$("#CurrencySelect").click(function () {
    Currency = $("#CurrencySelect").val();
});
//#endregion

//#region Button Handlers & Validation
//Allowance (Back is handled by ASP)
$("#Budget-Button-Allowance").click(function () {
    HideError();
    if ($("#Allowance").val() != "") {
        $("#Budget-Allowance").hide();
        $("#Budget-Expenditure").slideToggle();
        //The user has set their preferred currency. Update the rest of the form.
        UpdateCurrency();
    }
    else {
        DisplayError("Please define an allowance");
    }
});

//Expenditure
$("#Budget-Button-Next-Expenditure").click(function () {
    HideError();
    if ($("#Expenditure").val() != "") {
        $("#Budget-Expenditure").hide();
        $("#Budget-Income").slideToggle();
    }
    else {
        DisplayError("Please define an expenditure");
    }
});
$("#Budget-Button-Back-Expenditure").click(function () {
    HideError();
        $("#Budget-Expenditure").hide();
        $("#Budget-Allowance").slideToggle();
});

//Income
$("#Budget-Button-Next-Income").click(function () {
    HideError();
    if ($("#Income").val() != "") {
        $("#Budget-Income").hide();
        //Submit Form
    }
    else {
        DisplayError("Please define an Income");
    }
});
$("#Budget-Button-Back-Income").click(function () {
    HideError();
    $("#Budget-Income").hide();
    $("#Budget-Expenditure").slideToggle();
});
//#endregion


