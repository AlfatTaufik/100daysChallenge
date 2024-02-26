function cartesianProduct(setA, setB) {
    const product = [];
    for (let elementA of setA) {
        for (let elementB of setB) {
            product.push([elementA, elementB]);
        }
    }
    return product;
}

const setA = [1, 2];
const setB = [3, 4];
console.log("Cartesian Product:", cartesianProduct(setA, setB));