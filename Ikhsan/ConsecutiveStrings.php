<?php

function longestConsec($strarr, $k) {
    $n = count($strarr);

    if ($n == 0 || $k > $n || $k <= 0) {
        return "";
    }

    $longest = "";

    for ($i = 0; $i <= $n - $k; $i++) {
        $currentConcatenation = implode("", array_slice($strarr, $i, $k));

        if (strlen($currentConcatenation) > strlen($longest)) {
            $longest = $currentConcatenation;
        }
    }

    return $longest;
}

var_dump(longestConsec(["zone", "abigail", "theta", "form", "libe", "zas"], 2)); // string(12) "abigailtheta"