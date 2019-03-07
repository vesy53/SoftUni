function capitalCaseWords(arr) {
    let text = arr.join(',');
    let words = text.split(/\W+/);
    let nonEmptyWords = words.filter(w => w.length > 0);
    let upperWords = nonEmptyWords.filter(u => u === u.toUpperCase());

    console.log(upperWords.join(', '));
}