const fibonacci = n => {
    if (n==1 || n==2) return 1;
    return fibonacci(n-1)+fibonacci(n-2);
  };
  
  const fibonacci_row = fibN => {
    let fibs = [];
    for(i = 1; i <= fibN; i++){
        fibs.push(fibonacci(i));
    }
    return fibs;
  };
// test this like:
// fibonacci_row(10); // ten digits of fibonacci row, inserted in mas
