<?php

function isIsogram($string)
{
    $strLower = strtolower($string);

    $seenLeters = [];

    for ($i = 0; $i < strlen($strLower); $i++) {
        $letter = $strLower[$i];

        if (in_array($letter, $seenLeters)) {
            return false;
        }

        $seenLeters[] = $letter;
    }

    return true;
}

var_dump(isIsogram("Dermatoglyphics"));
// true

var_dump(isIsogram("aba"));
// false


/**
 * Isogram adalah kata yg tidak memiliki huruf berulang, berurutan atau tidak berurutan
 * 
 */