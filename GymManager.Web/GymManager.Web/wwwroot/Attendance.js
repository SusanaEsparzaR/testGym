
$(function () {
    const $eventEnter = document.getElementById("btnRegister");
    $eventEnter.addEventListener('click', function (e) {
        register();
    });
});

$(function () {
    const $eventEnter = document.getElementById("inputMemberId");
    $eventEnter.addEventListener('keypress', function (e) {
        if (e.key === 'Enter') {
            e.preventDefault();
            register();
        }
    });
});


function register() {
    const memberId = document.getElementById("inputMemberId").value;
    document.getElementById("show_memeber_id").innerHTML = memberId + " - " + new Date();
    $("#exampleModal").modal("show");
    setTimeout(hide, 3000);
}

function hide() {
    $("#exampleModal").modal("hide");
}