$(function () {
    $("#postButton").click(function () {
        //alert("hello");
        //$.post("https://localhost:5001/api/File", {  }, function (data) {
        //    // actions upon receiving the reply
        //    alert("Data received: " + data);
        //});

        $.ajax({
            type: 'POST',
            url: 'https://localhost:5001/api/File',
            //data: "{'name': 'nouman','email': 'noumandilawar@gmail.com','mobile_number': 03324412764,'employee_number': 4556, 'gender': 1,'password': '1234567891234567','language': 1}",
            //data: "sbc",
            //data: '{"id": "nouman","name":"nouman"}',
            data: '{"field1": "string"}',
            contentType: "text/json",
            dataType: 'text',
            crossDomain: true,
            success: OnGetMemberSuccess,
            error: OnGetMemberError
        });
    });

    function OnGetMemberSuccess(data, status) {
        //alert(data + "   " + status);
    }

    function OnGetMemberError(request, status, error) {
        alert(request + "  " + error + "   " + status);
    }
})