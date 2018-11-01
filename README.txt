Fractions.
This is an educational task teaching how to Work with several objects, with “this” pointer and enum:
1. Create a solution with Formula and Fraction classes
2. Fraction class:
  -  A fraction has a numerator and a denominator - once the fraction is created, they must be unchangeable;
  - Fraction must have the following methods: Sum, Subtraction, Multiplication, Dividing. All of these methods must be overloaded.
  The first method takes a fraction as an argument and the second takes a double number, e.g.: Sum(Fraction fraction) or Sum(double number).
  The result of each operation should return a new fraction (the old ones remain unchanged.)
3. Formula class must contain only one method, which declare one math operation with fractions or double numbers.
  Creating a formula should look like:
    - Formula (fraction, multiply, fraction) - the second parameter is the value of enum;
    - Formula(fraction, operation, number);
    - Formula(number, operation, number);
    - Formula(number, operation, fraction);
  That is Formula has only one method: to count where the required math method is called.
4. Create a Main class and taste how it works
