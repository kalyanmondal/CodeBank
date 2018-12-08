$(document).ready(function () {
    var ulEmployee = $('#ulEmployess');

    $('#btnGetEmployee').click(function () {

        $.ajax({
            type: 'GET',
            url: 'http://localhost:6120/api/Employee/',
            headers: {
                'Authorization' : 'Basic ' + btoa('male:male')
            },
            dataType: 'json',   ////jsonp
            success: function (data) {
                ulEmployee.empty();
                $.each(data, function (index, val) {
                    var fullName = val.FirstName + ' ' + val.LastName;

                    ulEmployee.append('<li>' + fullName + '(' + val.Gender + ')' +'</li>');
                });
            },
            complete: function (jqXHR) {
                if (jqXHR.status == '401') {
                    ulEmployee.empty();
                    ulEmployee.append('<li style="color:red">' + jqXHR.status + ' : ' + jqXHR.statusText + '</li>')
                }
            }
        });
    });

    $('#btnClear').click(function () {
        ulEmployee.empty();
    });
});