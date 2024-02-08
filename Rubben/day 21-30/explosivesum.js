function sum(n) {
    let partition = Array(n + 1).fill(0);
    partition[0] = 1;
    for (let i = 1; i <= n; i++) {
        for (let j = i; j <= n; j++) {
            partition[j] += partition[j - i];
        }
    }
    return partition[n];
}