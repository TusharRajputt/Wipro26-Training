$(document).ready(function () {
    function loadPage(pageFile) {
        $("#content").load(`html/${pageFile}`, function (response, status) {
            if (status === "error") {
                $("#content").html("<p>Unable to load content right now.</p>");
            }
        });
    }

    loadPage("home.html");

    $("#homeBtn").click(function () {
        loadPage("home.html");
    });

    $("#aboutBtn").click(function () {
        loadPage("about.html");
    });

    $("#contactBtn").click(function () {
        loadPage("contact.html");
    });

    $("#content").on("submit", "#contactForm", function (event) {
        event.preventDefault();
        alert("Thanks! Your message has been submitted.");
        this.reset();
    });
});