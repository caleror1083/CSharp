$(document).ready(function () {
    var randomNumber = 0;
    var greenGemNmbr = 0;
    var redGemNmbr = 0;
    var yellowGemNmbr = 0;
    var purpleGemNmbr = 0;
    var yourScoreIs = 0;
    var wins = 0;
    var losses = 0;

    function randomNumberGenerator() {
        // returns a number between 19 and 120
        randomNumber = Math.floor(Math.random() * 120 - 19 + 1) + 19;
        // checking via console
        console.log("The Random Number is: " + randomNumber);
        // display the random number on the page
        $("#randomNumberId").html(randomNumber);
    }

    function getRandomGemValue(color) {
        return Math.floor(Math.random() * 12) + 1;
    }

    // create a function that generates the random number for the gems so we can call it later
    function randomGemValuesGenerator() {

        // returns a number between 1 and 12 for the green diamond
        greenGemNmbr = getRandomGemValue("green");
        console.log("The Green Diamond's value is: " + greenGemNmbr);

        // returns a number between 1 and 12 for the red diamond
        redGemNmbr = getRandomGemValue("red");
        console.log("The Red Diamond's value is: " + redGemNmbr);

        // returns a number between 1 and 12 for the yellow diamond
        yellowGemNmbr = getRandomGemValue("yellow");
        console.log("The Yellow Diamond's value is: " + yellowGemNmbr);

        // returns a number between 1 and 12 for the purple diamond
        purpleGemNmbr = getRandomGemValue("purple");
        console.log("The Purple Diamond's value is: " + purpleGemNmbr);
    }

    randomNumberGenerator();
    randomGemValuesGenerator();

    // every time each crystal is clicked, add each crystal's value to the total score and diaplay it
    function gemClicked(gemName, gemValue) {
        yourScoreIs = yourScoreIs + gemValue;
        console.log(yourScoreIs);
        $("#yourScore").html(yourScoreIs);

        // conditions for win or loss are checked after every click
        // when user wins, update wins, update message
        if (yourScoreIs === randomNumber) {
            wins++;
	        $("#wins").html("Wins: " +wins);
            $("#message").html("YOU WIN!");
	        console.log("YOU WIN!");
	  
            // reset your score, random number and gem values
	        randomNumberGenerator();
            randomGemValuesGenerator();
            yourScoreIs = 0;
            $("#yourScore").html(yourScoreIs);
        }

        // when user loses, update losses, update message, reset random number and gem values
        if (yourScoreIs > randomNumber) {
            losses++;
            $("#losses").html("Losses: " + losses);
            $("#message").html("YOU LOSE!");
            console.log("YOU LOSE!");

            // reset your score, random number and gem values
            randomNumberGenerator();
            randomGemValuesGenerator();
            yourScoreIs = 0;
            $("#yourScore").html(yourScoreIs);
        }
    }

    // when each gem is clicked, call the gemClicked function and pass in the gem name and value
    $("#greenGem").on("click", function () {
        gemClicked("greenGem", greenGemNmbr);
    });

    $("#redGem").on("click", function () {
        gemClicked("redGem", redGemNmbr);
    });

    $("#yellowGem").on("click", function () {
        gemClicked("yellowGem", yellowGemNmbr);
    });

    $("#purpleGem").on("click", function () {
        gemClicked("purpleGem", purpleGemNmbr);
    });

    // reset game stats, when the user clicks on the reset button, reset all game stats
    $("#reset").on("click", function () {
			wins = 0;
			losses = 0;
			yourScoreIs = 0;
			$("#wins").html("Wins: " + 0);
			$("#losses").html("Losses: " + 0);
			$("#yourScore").html(yourScoreIs);
			$("#message").html();
			randomNumberGenerator();
			randomGemValuesGenerator();
    });
});