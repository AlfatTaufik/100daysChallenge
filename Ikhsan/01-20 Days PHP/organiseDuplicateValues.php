<?php 
function group(array $arr) {
    $result = [];
    $numberOccurrences = [];

    foreach ($arr as $n) {
        if (!isset($numberOccurrences[$n])) {
            $numberOccurrences[$n] = array();
        }
        $numberOccurrences[$n][] = $n;
    }

    foreach ($numberOccurrences as $occurrence) {
        $result[] = $occurrence;
    }

    return $result;
}

print_r(group([1,2,3,4,3,3,5,6,1,1])); // [[1,1,1], [2], [3,3,3], [5], [6]]

?>