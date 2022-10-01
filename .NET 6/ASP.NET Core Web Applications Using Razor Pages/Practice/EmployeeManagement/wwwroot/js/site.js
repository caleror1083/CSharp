const isbn = document.getElementById('ISBN');

isbn.addEventListener("keydown", (e) => {
    if (e.key === "Backspace" || e.key === "Delete") {
		return;
	}
    if (e.target.value.length === 3) {
        isbn.value = isbn.value + "-";
    }
    if(e.target.value.length === 5) {
        isbn.value = isbn.value + "-";
    }
    if(e.target.value.length === 8) {
        isbn.value = isbn.value + "-";
    }
    if(e.target.value.length === 15) {
        isbn.value = isbn.value + "-";
    }
})