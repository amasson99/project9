using System;

public class FractionApp {

    public static void main(string [] args){
      //Scanner in = new Scanner(System.in);
      int MAXAMOUNT = 3;
      string [] userInput = new string [MAXAMOUNT];
      Fraction [] fractionArray = new Fraction [MAXAMOUNT];
      for (int j = 0; j < MAXAMOUNT; j++){
        fractionArray[j] = new Fraction();
      }
      Console.Write("Enter a problem: ");
      string userResponse = Console.ReadLine();

      //Scanner x = new Scanner (userResponse);
      userInput[0] = Console.ReadLine();

      string[] stringArray = userInput[0].split("/");
      int[] intArray = new int[stringArray.length];

      for (int i = 0; i < stringArray.length; i++) {
         string numberAsString = stringArray[i];
         intArray[i] = Convert.ToInt32(numberAsString);
      }
      if (stringArray.length == 1){
        int numerator1 = intArray[0];
        int denominator1 = 1;
        /**
         * This is the setter for the Fraction constructor
         *
         * @param n, numerator of the function
         *
         * @return Nothing
         */
        fractionArray[0].setNumerator(numerator1);
        /**
         * this is the setter for the fraction constructor
         *
         * @param d the denominator for the fraction
         * (list all parameters, one per line)
         * @return nothing
         */
        fractionArray[0].setDenominator(denominator1);
        //System.out.println("Fraction 1 = " + fractionArray[0].toString());
      } else {
        int numerator1 = intArray[0];
        int denominator1 = intArray[1];
        /**
         * This is the setter for the Fraction constructor
         *
         * @param n, numerator of the function
         *
         * @return Nothing
         */
        fractionArray[0].setNumerator(numerator1);
        /**
         * this is the setter for the fraction constructor
         *
         * @param d the denominator for the fraction
         * (list all parameters, one per line)
         * @return nothing
         */
        fractionArray[0].setDenominator(denominator1);
        //System.out.println("Fraction 1 = " + fractionArray[0].toString());
      }

      string operator = Console.ReadLine();

      userInput[1] = Console.Readline();
      string[] stringArray1 = userInput[1].split("/");
      int[] intArray1 = new int[stringArray1.length];

      for (int i = 0; i < stringArray1.length; i++) {
         string numberAsString1 = stringArray1[i];
         intArray1[i] = Convert.ToInt32(numberAsString1);
      }
      if (stringArray1.length == 1){
        int numerator2 = intArray1[0];
        int denominator2 = 1;
        /**
         * This is the setter for the Fraction constructor
         *
         * @param n, numerator of the function
         *
         * @return Nothing
         */
        fractionArray[1].setNumerator(numerator2);
        /**
         * this is the setter for the fraction constructor
         *
         * @param d the denominator for the fraction
         * (list all parameters, one per line)
         * @return nothing
         */
        fractionArray[1].setDenominator(denominator2);
        //System.out.println("Fraction 2 = " + fractionArray[1].toString());
      } else {
        int numerator2 = intArray1[0];
        int denominator2 = intArray1[1];
        /**
         * This is the setter for the Fraction constructor
         *
         * @param n, numerator of the function
         *
         * @return Nothing
         */
        fractionArray[1].setNumerator(numerator2);
        /**
         * this is the setter for the fraction constructor
         *
         * @param d the denominator for the fraction
         * (list all parameters, one per line)
         * @return nothing
         */
        fractionArray[1].setDenominator(denominator2);
        //System.out.println("Fraction 2 = " + fractionArray[1].toString());
      }
      if(operator.equals("+")){
        /**
         * Adds the two fractions
         *
         * @param Fraction, the fraction being called upon
         * @param f, the fraction being compared to
         * (list all parameters, one per line)
         * @return A reduced fraction that is the answer
         */
        fractionArray[2] = fractionArray[0].plus(fractionArray[1]);
        /**
         * Makes a string to print all values
         *
         *
         * @return A string of the fraction
         */
        Console.WriteLine(fractionArray[0].toString() + " + " + fractionArray[1].toString() + " = " + fractionArray[2].toString());
      } else if(operator.equals("-")){
        /**
         * Subtracts the two fractions
         *
         * @param Fraction, the fraction being called upon
         * @param f, the fraction being compared to
         * (list all parameters, one per line)
         * @return A reduced fraction that is the answer
         */
        fractionArray[2] = fractionArray[0].minus(fractionArray[1]);
        /**
         * Makes a string to print all values
         *
         *
         * @return A string of the fraction
         */
        System.out.println(fractionArray[0].toString() + " - " + fractionArray[1].toString() + " = " + fractionArray[2].toString());
      } else if(operator.equals("/")){
        /**
         * Divides the two fractions
         *
         * @param Fraction, the fraction being called upon
         * @param f, the fraction being compared to
         * (list all parameters, one per line)
         * @return A reduced fraction that is the answer
         */
        fractionArray[2] = fractionArray[0].divide(fractionArray[1]);
        /**
         * Makes a string to print all values
         *
         *
         * @return A string of the fraction
         */
        Console.WriteLine(fractionArray[0].toString() + " / " + fractionArray[1].toString() + " = " + fractionArray[2].toString());
      } else if(operator.equals("*")){
        /**
         * Multiplies the two fractions
         *
         * @param Fraction, the fraction being called upon
         * @param f, the fraction being compared to
         * (list all parameters, one per line)
         * @return A reduced fraction that is the answer
         */
        fractionArray[2] = fractionArray[0].times(fractionArray[1]);
        /**
         * Makes a string to print all values
         *
         *
         * @return A string of the fraction
         */
       Console.WriteLine(fractionArray[0].toString() + " * " + fractionArray[1].toString() + " = " + fractionArray[2].toString());
      }// end else if
      /**
       * Says whether the fractions equal each other
       *
       * @param Fraction, the fraction being called upon
       * @param f, the fraction being compared to
       * (list all parameters, one per line)
       * @return a true or false stating whether the fractions equal eachother
       */
      boolean equals = fractionArray[0].equals(fractionArray[1]);

      if(equals == true){
        Console.WriteLine("Fraction1 equals Fraction2");
      } else {
        Console.WriteLine("Fraction1 does NOT equals Fraction2");
      }


}//end main

}//end class
