
        function createAccount() {
            var fullName = document.getElementById("name").value;
            var email = document.getElementById("Email").value;
            var password = document.getElementById("password").value;
            var confirmPassword = document.getElementById("confirm").value;
            var agreeCheckbox = document.getElementById("form-checkbox").checked;

            // Perform form validation
            if (!fullName || !email || !password || !confirmPassword || !agreeCheckbox) {
                showAlert("Please fill in all required fields.");
                return;
            }

            // Perform additional form validation and account creation logic here
            // ...

            // Example: Displaying the entered data in the console
            console.log("Full Name: " + fullName);
            console.log("Email Address: " + email);
            console.log("Password: " + password);
            console.log("Confirm Password: " + confirmPassword);
            console.log("Agreed to Terms: " + agreeCheckbox);

            // Submit the form or perform other actions
            // ...
        }

        function showAlert(message) {
            var alertBox = document.getElementById("alert-box");
            alertBox.innerText = message;
            alertBox.style.display = "block";
        }



