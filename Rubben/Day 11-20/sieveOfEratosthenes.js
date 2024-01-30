function sieveOfEratosthenes(n) {
    let primes = Array(n + 1).fill(true);
    primes[0] = primes[1] = false;
    let sqrtN = Math.sqrt(n);

    for (let i = 2; i <= sqrtN; i++) {
        if (primes[i]) {
            for (let j = i * i; j <= n; j += i) {
                primes[j] = false;
            }
        }
    }

    let result = [];
    for (let i = 2; i <= n; i++) {
        if (primes[i]) {
            result.push(i);
        }
    }

    return result;
}

console.log(sieveOfEratosthenes(100)); 