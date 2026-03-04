function getButtonElement() {
    return document.getElementById("fetchBtn") || document.getElementById("generateBtn");
}

function getUserInfoElement() {
    return document.getElementById("userInfo");
}

function setMessage(message) {
    const userInfo = getUserInfoElement();
    if (userInfo) {
        userInfo.innerHTML = `<p>${message}</p>`;
    }
}

async function fetchUser() {
    const userInfo = getUserInfoElement();
    if (!userInfo) {
        return;
    }

    setMessage("Loading...");

    try {
        const response = await fetch("https://randomuser.me/api/");
        if (!response.ok) {
            throw new Error(`HTTP ${response.status}`);
        }

        const data = await response.json();
        const user = data?.results?.[0];

        if (!user) {
            throw new Error("No user data returned");
        }

        const name = `${user.name.first} ${user.name.last}`;
        const email = user.email;
        const picture = user.picture.large;

        userInfo.innerHTML = `
            <h3>${name}</h3>
            <p>Email: ${email}</p>
            <img src="${picture}" width="150" alt="${name}">
        `;
    } catch (error) {
        console.error("Error:", error);
        setMessage("Unable to load user. Please try again.");
    }
}

document.addEventListener("DOMContentLoaded", () => {
    const button = getButtonElement();
    if (!button) {
        console.error("Button not found. Expected #fetchBtn or #generateBtn");
        return;
    }

    button.addEventListener("click", fetchUser);
});