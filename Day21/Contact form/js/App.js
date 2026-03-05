$(document).ready(function () {
    const useFileProtocol = window.location.protocol === "file:";
    const localPages = {
        "home.html": `
            <h2>Home Page</h2>
            <p>Welcome to our website. This is the home page of our SPA.</p>
        `,
        "about.html": `
            <h2>About Us</h2>
            <p>This website is built using jQuery Single Page Application concept.</p>
        `,
        "contact.html": `
            <h2>Contact Us</h2>
            <form id="contactForm">
                <label>Name:</label>
                <input type="text" id="name" required>

                <label>Email:</label>
                <input type="email" id="email" required>

                <label>Message:</label>
                <textarea id="message" required></textarea>

                <button type="submit">Submit</button>
            </form>
        `
    };

    function loadPage(pageFile) {
        if (useFileProtocol) {
            $("#content").html(localPages[pageFile] || "<p>Page not found.</p>");
            return;
        }

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