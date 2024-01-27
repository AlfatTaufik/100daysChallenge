function convertRupiah(amount) {
    const rupiah = [100000, 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100];
    let remaining = amount;
    let result = {};

    for (let i = 0; i < rupiah.length; i++) {
        if (remaining >= rupiah[i]) {
            let count = Math.floor(remaining / rupiah[i]);
            remaining -= count * rupiah[i];
            result[rupiah[i]] = count;
        }
    }

    if (remaining > 0) {
        result[100] = result[100] ? result[100] + 1 : 1;
    }

    return result;
}

console.log(convertRupiah(1232))