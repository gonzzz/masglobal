function GetEmployees(table)
{
	disableControls();

	$.ajax({
		url: '/api/Employees',
		type: 'GET',
		contentType: 'application/json; charset=utf-8',
		dataType: 'json',
		success: function (result)
		{
			enableControls();

			var rows = '';
			if (result.length > 0)
			{
				$.each(result, function (key, value)
				{
					rows += '<tr>';
					rows += '<td>' + value.id + '</td>';
					rows += '<td>' + value.name + '</td>';
					rows += '<td>' + value.contractTypeName + '</td>';
					rows += '<td>' + value.roleName + '</td>';
					rows += '<td class="currency">' + value.salary + '</td>';
					rows += '<td class="currency">' + value.annualSalary + '</td>';
					rows += '<td data-id="' + value.id + '"></td>';
					rows += '</tr>';
				});
			} else
			{
				rows += '<tr><td colspan="7">No Employee(s)</td></tr>';
			}

			table.find('tbody').html(rows);

			formatCurrencyColumns();
		},
		error: function (xhr)
		{
			enableControls();

			alert('There was an error retreving the employees!');			
		}
	});
}

function SearchEmployeesById(table, id)
{
	disableControls();

	$.ajax({
		url: '/api/Employees/' + id,
		type: 'GET',
		contentType: 'application/json; charset=utf-8',
		dataType: 'json',
		success: function (result)
		{
			enableControls();

			var rows = '';
			if (result !== null && result !== undefined)
			{
				rows += '<tr>';
				rows += '<td>' + result.id + '</td>';
				rows += '<td>' + result.name + '</td>';
				rows += '<td>' + result.contractTypeName + '</td>';
				rows += '<td>' + result.roleName + '</td>';
				rows += '<td class="currency">' + result.salary + '</td>';
				rows += '<td class="currency">' + result.annualSalary + '</td>';
				rows += '<td data-id="' + result.id + '"></td>';
				rows += '</tr>';
			}
			else
			{
				rows += '<tr><td colspan="7">No Employee(s)</td></tr>';
			}

			table.find('tbody').html(rows);

			formatCurrencyColumns();
		},
		error: function (xhr)
		{
			enableControls();

			if(xhr.status === 404)
			{
				alert('The Employee with id "' + id + '" was not found!');
			}
			else
			{
				alert('There was an error retreving the employees!');
			}
		}
	});
}

function disableControls()
{
	$('#search_box').attr('disabled', true);
	$('#search_btn').html('<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span> Loading...');
	$('#table-employees').css('opacity', 0.5);
}

function enableControls()
{
	$('#search_box').attr('disabled', false);
	$('#search_btn').html('Search');
	$('#table-employees').css('opacity', 1.0);
}

function formatCurrencyColumns()
{
	$('.currency').inputmask('decimal',
		{
			'alias': 'numeric',
			'groupSeparator': '.',
			'autoGroup': true,
			'digits': 2,
			'radixPoint': ",",
			'digitsOptional': false,
			'allowMinus': false,
			'prefix': '$ ',
			'placeholder': '0'
		}
	);
}

