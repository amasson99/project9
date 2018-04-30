/**
* Fraction.java
* Alex Masson / Thursday / 4:30
*
* This class contains the methods to do four different calculations of a fraction
*/

using System;
public class Fraction {

    private int numerator;             // Fraction numerator
    private int denominator;           // Fraction denominator

  /**
   * This is the no parameter class for the fraction, so the program wont crash if the user enters nothing
   *
   *
   *
   */
    public Fraction() {
        numerator = 1;
        denominator = 1;
    }

    /**
     * This is the one argument parameter class
     * @param n the numerator for the class
     *
     */
    public Fraction(int n) {
        numerator = n;
        denominator = 1;
    }

    /**
     * This is the two parameter class
     *
     * @param n, numerator of the fraction
     * @param d, denominator of the fractions
     * (list all parameters, one per line)
     *
     */
    public Fraction(int n, int d) {
        numerator = (d < 0 ? -n : n);
        if (d == 0) {
            denominator = 1;
        }
        denominator = (d < 0 ? -d : d);
        reduce();
    }
    /**
     * This is the setter for the Fraction constructor
     *
     * @param n, numerator of the function
     *
     * @return Nothing
     */
    public void setNumerator(int n) {
        numerator = n;
        reduce();
    }

    /**
     * This gets the numerator for the Fraction constructor
     *
     *
     * (list all parameters, one per line)
     * @return numerator for the fraction
     */
    public int getNumerator() {
        return numerator;
    }

    /**
     * this is the setter for the fraction constructor
     *
     * @param d the denominator for the fraction
     * (list all parameters, one per line)
     * @return nothing
     */
    public void setDenominator(int d) {
        if (d > 0) {
            denominator = d;
            reduce();
        }
        else if (d < 0) {
            numerator = -numerator;
            denominator = -d;
            reduce();
        }
    }

    /**
     * This gets the denominator for the Fraction constructor
     *
     *
     * (list all parameters, one per line)
     * @return denominator for the fraction
     */
    public int getDenominator() {
        return denominator;
    }

    /**
     * Adds the two fractions
     *
     * @param Fraction, the fraction being called upon
     * @param f, the fraction being compared to
     * (list all parameters, one per line)
     * @return A reduced fraction that is the answer
     */
    public Fraction plus(Fraction f) {
        Fraction sum = new Fraction();
        sum.denominator = denominator * f.denominator;
        sum.numerator = numerator * f.denominator + denominator * f.numerator;
        sum.reduce();
        return sum;
    }
    /**
     * Subtracts the two fractions
     *
     * @param Fraction, the fraction being called upon
     * @param f, the fraction being compared to
     * (list all parameters, one per line)
     * @return A reduced fraction that is the answer
     */
    public Fraction minus(Fraction f) {
        Fraction minus = new Fraction();
        minus.denominator = denominator * f.denominator;
        minus.numerator = numerator * f.denominator - denominator * f.numerator;
        minus.reduce();
        return minus;
    }
    /**
     * Multiplies the two fractions
     *
     * @param Fraction, the fraction being called upon
     * @param f, the fraction being compared to
     * (list all parameters, one per line)
     * @return A reduced fraction that is the answer
     */
    public Fraction times(Fraction f) {
        Fraction times = new Fraction();
        times.denominator = denominator * f.denominator;
        times.numerator = numerator * f.numerator;
        times.reduce();
        return times;
    }
    /**
     * Divides the two fractions
     *
     * @param Fraction, the fraction being called upon
     * @param f, the fraction being compared to
     * (list all parameters, one per line)
     * @return A reduced fraction that is the answer
     */
    public Fraction divide(Fraction f) {
        Fraction divide = new Fraction();
        divide.denominator = denominator * f.numerator;
        divide.numerator = numerator * f.denominator;
        divide.reduce();
        return divide;
    }

    /**
     * Makes a string to print all values
     *
     *
     * @return A string of the fraction
     */
    public string toString() {
        string bob = numerator.ToString();
        bob += "/";
        bob += denominator.ToString();
        return bob;
    }

    /**
     * Says whether the fractions equal each other
     *
     * @param Fraction, the fraction being called upon
     * @param f, the fraction being compared to
     * (list all parameters, one per line)
     * @return a true or false stating whether the fractions equal eachother
     */
    public bool equals(Fraction f) {
        return (numerator == f.numerator) && (denominator == f.denominator);
    }

    /**
     * Reduces the fraction to the lowest terms
     *
     *
     * (list all parameters, one per line)
     * @return nothing
     */
    private void reduce() {
        int n = numerator, d = denominator, largest;
        if (numerator < 0) {
            n = -numerator;
        }
        if (n > d) {
            largest = n;
        }
        else {
            largest = d;
        }


        int gcd = 0;
        for (int i = largest; i >= 2; i--) {
            if (numerator % i == 0 && denominator % i == 0) {
                gcd = i;
                break;
            }
        }


        if (gcd != 0) {
            numerator /= gcd;
            denominator /= gcd;
        }
    }
}
