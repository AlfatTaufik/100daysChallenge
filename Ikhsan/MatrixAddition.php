<?php
function matrix_addition(array $a, array $b): array {
  $n = count($a);
  $result = array_fill(0, $n, array_fill(0, $n, 0));

  for ($i = 0; $i < $n; $i++) {
      for ($j = 0; $j < $n; $j++) {
          $result[$i][$j] = $a[$i][$j] + $b[$i][$j];
      }
  }

  return $result;
}

$a = [
    [1, 2, 3],
    [3, 2, 1],
    [1, 1, 1]
];

$b = [
    [2, 2, 1],
    [3, 2, 3],
    [1, 1, 3]
];

$result = matrix_addition($a, $b);
print_r($result); 
/**
 * [
 *  [3,4,4],
 *  [6,4,4],
 *  [2,2,4]
 * ]
 */