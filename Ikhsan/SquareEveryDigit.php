<?php

function square_digits($num) {
    $digits = str_split((string)$num);
    $squaredDigits = array_map(fn ($n) => $n ** 2, $digits);
    $result = (int)implode('', $squaredDigits);
    return $result;
}

var_dump(square_digits(9119)); // 811181 -> 9^2=81; 1^2=1; 1^2=1; 9^2=81 