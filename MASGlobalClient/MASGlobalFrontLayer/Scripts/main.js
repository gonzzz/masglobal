function RefreshEmployeesGrid()
{
    var tableEmployees = $('#table-employees');
    var search_criteria = $('#search_box').val();

    if (search_criteria === '' || search_criteria === null)
    {
        GetEmployees(tableEmployees);
    }
    else
    {

        if (!$.isNumeric(search_criteria))
        {
            ShowSearchCriteriaError();
            $('#search_box').val('');
        }
        else
        {
            SearchEmployeesById(tableEmployees, search_criteria);
        }
    }
}

function ShowSearchCriteriaError()
{
    alert("Wrong Criteria!You can only search by Employee Id.");
}