function isValidEmail(email) {
    return /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email);
}

function doesPasswordMatch() {
    var Password = document.getElementById('password').value;
    var ConfirmPassword = document.getElementById('confirmpassword').value;

    if (Password == '' || ConfirmPassword == '') {
        return false;
    }

    return Password == ConfirmPassword;
}

function isValidPhoneNum(phonenum) {
    return /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im.test(phonenum);
}

function onFormSubmit() {
    var emailAddress = document.getElementById('email').value;
    var phonenum = document.getElementById('phoneNumber').value;

    if (!isValidEmail(emailAddress)) {
        alert('You have entered an invalid email address.');
        return false;
    }

    if (!doesPasswordMatch()) {
        alert('Please ensure password and password confirm fields are not blank and match.');
        return false;
    }

    if (!isValidPhoneNum(phonenum)) {
        alert('Please enter a valid phone number.');
        return false;
    }

    return true;
}