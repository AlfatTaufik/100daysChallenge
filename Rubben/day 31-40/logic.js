// NOT Gate
function notGate(input) {
    return !input;
}

// AND Gate
function andGate(input1, input2) {
    return input1 && input2;
}

// OR Gate
function orGate(input1, input2) {
    return input1 || input2;
}

// NAND Gate
function nandGate(input1, input2) {
    return !(input1 && input2);
}

// NOR Gate
function norGate(input1, input2) {
    return !(input1 || input2);
}

// XOR Gate
function xorGate(input1, input2) {
    return (input1 || input2) && !(input1 && input2);
}

