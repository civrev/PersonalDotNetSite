
var editBtnOrgTxt;

function editCard(btn) {
    var editableContent = btn.previousElementSibling;
    var staticContent = btn.nextElementSibling;

    if (btn.classList.contains("clicked")) {
        btn.classList.remove("clicked");
        btn.textContent = editBtnOrgTxt;
        editableContent.style.display = "none";
        staticContent.style.display = "initial";
    } else {
        btn.classList.add("clicked");
        editBtnOrgTxt = btn.textContent;
        btn.textContent = "Stop Edit"
        editableContent.style.display = "initial";
        staticContent.style.display = "none";
    }
}

function showBiggerCard(element) {

    var cardBody = element.parentElement.parentElement;
    var cardBigImage = cardBody.previousElementSibling;
    var cardSmallImage = cardBigImage.previousElementSibling;
    var cardLongDesc = element.previousElementSibling;
    var cardShortDesc = cardLongDesc.previousElementSibling;
    var card = cardBody.parentElement;
    var cardContainer = card.parentElement;
    var editBtn = null;

    if (element.parentElement.previousElementSibling != null) {
        editBtn = element.parentElement.previousElementSibling;
    }

    if (cardContainer.classList.contains("bigCard")) {

        //card is big so make it small
        cardContainer.classList.remove("bigCard");
        cardContainer.classList.remove("col-md-12");
        cardContainer.classList.add("col-md-3");

        //put back
        cardContainer.style.position = "initial";
        cardContainer.style.zIndex = "0";

        //change deminsion limits
        card.style.maxWidth = "18rem";

        //flip shown elements
        cardSmallImage.style.display = "block";
        cardBigImage.style.display = "none";

        cardShortDesc.style.display = "block";
        cardLongDesc.style.display = "none";

        if (editBtn != null) {
            editBtn.style.display = "none";
        }

        //now it is small so change text back
        element.textContent = "Show More";

        //put user in view of card
        card.scrollIntoView();

    } else {


        //card is small, so make it big
        cardContainer.classList.add("bigCard");
        cardContainer.classList.remove("col-md-3");
        cardContainer.classList.add("col-md-12");

        //put at top
        cardContainer.style.position = "absolute";
        cardContainer.style.zIndex = "5";

        //change deminsion limits
        card.style.maxWidth = "180rem";

        //flip shown elements
        cardSmallImage.style.display = "none";
        cardBigImage.style.display = "block";

        cardShortDesc.style.display = "none";
        cardLongDesc.style.display = "block";

        if (editBtn != null) {
            editBtn.style.display = "block";
        }

        //now it is big so update button text
        element.textContent = "Show Less";

        //put user in view of card
        card.scrollIntoView();

    }

}

function addNewCard(icon) {
    var newCard = icon.parentElement.parentElement.previousElementSibling;

    if (icon.classList.contains("clicked")) {
        icon.classList.remove("clicked");
        newCard.style.display = "none";
        icon.classList.remove("fa-minus-square");
        icon.classList.add("fa-plus-square");
    } else {
        icon.classList.add("clicked");
        newCard.style.display = "block";
        icon.classList.add("fa-minus-square");
        icon.classList.remove("fa-plus-square");
    }
}