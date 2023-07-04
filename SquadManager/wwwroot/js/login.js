$('form').on('submit', function (event) {
    event.preventDefault();

    var formData = {
        email: $("input[name='email']").val(),
        password: $("input[name='password']").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7291/api/User",
        success: function (result) {
            if (result.response == "ok")
                alert("Logado")
            else
                alert("Credenciais Inválidas")
        },
        error: function (error) {
            console.log(error);
        }
    })
});