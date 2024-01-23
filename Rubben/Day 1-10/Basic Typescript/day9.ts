function divideNumbers(a: number, b: number): number {
    try {
      if (b === 0) {
        throw new Error("Cannot divide by zero!");
      }
      return a / b;
    } catch (error: unknown) {
      if (error instanceof Error) {
        console.error("Error:", error.message);
      }
      return 0;
    }
  }
  
  const result1 = divideNumbers(10, 2);
  console.log("Result 1:", result1); 
  
  const result2 = divideNumbers(8, 0);
  console.log("Result 2:", result2); 
