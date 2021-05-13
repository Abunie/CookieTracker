// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function updateTimezone() {
    var timezone = Intl.DateTimeFormat().resolvedOptions().timeZone
    document.getElementById('timezone').innerHTML = "Your timezone: " + timezone;
}


