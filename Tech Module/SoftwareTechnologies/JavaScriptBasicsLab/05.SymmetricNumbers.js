function symmetricNumbers(numberStr) {
    let num = Number(numberStr[0]);

    for (let i = 1; i <= num; i++) {
        if(isSymmetricNum("" + i)){
            console.log(i);
        }
    }

    function isSymmetricNum(numb){
        for (let i = 0; i < numb.length; i++) {
            if(numb[i] != numb[numb.length - 1 - i]){
                return false;
            }
        }

        return true;
    }
}