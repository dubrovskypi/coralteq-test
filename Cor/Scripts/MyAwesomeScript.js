function selectItem(li, edit) {
    var text = li.innerText;
    edit.val(text);
    edit.change();
    edit.focus();
};

function clearInput(input) {
    input.val('');
    input.change();
    input.focus();
};

Opentip.styles.myStyle = {
    "extends": "standard",
    className: "myStyle",
    background: [[0, "rgba(255, 179, 0, 0.9)"], [0.5, "rgba(255, 179, 0, 0.9)"], [0.5, "rgba(255, 179, 0, 0.95)"], [1, "rgba(255, 179, 0, 0.95)"]],
    borderColor: "rgba(255, 179, 0, 0.5)",
    closeButtonCrossColor: "rgba(255, 255, 255, 1)",
    borderRadius: 5,
    closeButtonRadius: 10,
    closeButtonOffset: [8, 8]
};

function bindClearButton(Edit) {
    var deleteicon = Edit.parent('.input-group').find('.deleteicon');

    Edit.bind('change', function () {
        var inputGroup = Edit.parent('.input-group');
        if (Edit.val() != "") inputGroup.addClass('compl');
        else inputGroup.removeClass('compl');
    });

    Edit.bind('keyup', function () {
        Edit.val('');
        Edit.change();
        deleteicon.css('display', '');
    });

    Edit.bind('focus', function () {
        
        if (Edit.val() != "") deleteicon.css('display', 'inline-block');
        else deleteicon.css('display', '');
    });

    Edit.bind('blur', function () {
        deleteicon.css('display', '');
    });
};

//validation settings
function onSuccess(label, element) {
    label.display = 'none';
    var idErrorElement = '#' + element.name + 'E';
    var errorElement = $(idErrorElement);
    errorElement[0].style.display = 'none';
};

function onUnhighlight(element, errorClass, validClass) {
    $(element).removeClass(errorClass).addClass(validClass);
    var idErrorElement = '#' + element.name + 'E';
    var errorElement = $(idErrorElement);
    errorElement[0].style.display = 'none';
};

function onHighlight(element, errorClass, validClass) {
    $(element).addClass(errorClass).removeClass(validClass);
    var idErrorElement = '#' + element.name + 'E';
    var errorElement = $(idErrorElement);
    errorElement[0].style.display = 'block';
    var errorFromValidator = $.grep(this.errorList, function (e, index) {
        if (e.element == element) return true;
        return false;
    });
    var newcontent = errorFromValidator[0].message;
    var tips = Opentip.tips;
    if (tips.length != 0) {
        var tip = $.grep(tips, function (e, index) {
            if (e.triggerElement.selector == idErrorElement) return true;
            return false;
        });
        if (tip.length != 0) {
            if (tip[0].content != newcontent) {
                tip[0].setContent(newcontent);
                //alert("new content: " + newcontent);
            }
        } else {
            new Opentip(errorElement, newcontent, { showOn: 'mouseover', tipJoint: "top right", target: true, style: 'myStyle' });
        }
    } else new Opentip(errorElement, newcontent, { showOn: 'mouseover', tipJoint: "top right", target: true, style: 'myStyle' });
};

function myInvalidHandler(event, validator) {
    var tips = Opentip.tips;
    for (var i = 0; i < validator.numberOfInvalids() ; i++) {
        var name = validator.errorList[i].element.name;
        var message = validator.errorList[i].message;
        var idErrorElement = '#' + name + 'E';
        var errorElement = $(idErrorElement);
        errorElement[0].style.display = 'block';
        if (tips.length != 0) {
            for (var j in tips) {
                var b = true;
                if (tips[j].content == message) {
                    b = false;
                    break;
                }
            }
            if (b) {
                //alert("+tip+= " + message);
                new Opentip(errorElement, message, { showOn: 'mouseover', tipJoint: "top right", target: true, style: 'myStyle' });
            }
        } else {
            //alert("newtip+= " + message);
            new Opentip(errorElement, message, { showOn: 'mouseover', tipJoint: "top right", target: true, style: 'myStyle' });
        }
    }
};