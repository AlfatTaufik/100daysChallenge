let steps = (n, count = 0) => {
    if (n === 1) {
        console.log(`Langkah total: ${count}`);
        return count;
    }
    console.log(`Langkah ke-${count}: ${n}`);
    return steps(n % 2 === 0 ? n / 2 : n * 3 + 1, count + 1);
};

steps(20)
//genap = / 2
//ganjil = * 3 + 1