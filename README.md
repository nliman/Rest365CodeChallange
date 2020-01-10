# Rest365CodeChallange
Rest365CodeChallange

The following requirements have been implemented:

- Step 1: Support a maximum of 2 numbers using a comma delimiter. Throw an exception when more than 2 numbers are provided:
  - examples: 20 will return 20; 1,5000 will return 5001; 4,-3 will return 1
  - empty input or missing numbers should be converted to 0
  - invalid numbers should be converted to 0 e.g. 5,tytyt will return 5
- Step 2: Remove the maximum constraint for numbers e.g. 1,2,3,4,5,6,7,8,9,10,11,12 will return 78
- Step 3: Support a newline character as an alternative delimiter e.g. 1\n2,3 will return 6
- Step 4: Deny negative numbers by throwing an exception that includes all of the negative numbers provided
- Step 5:Make any value greater than 1000 an invalid number e.g. 2,1001,6 will return 8
- Step 6: Support 1 custom delimiter of a single character using the format: //{delimiter}\n{numbers}
  - examples: //#\n2#5 will return 7; //,\n2,ff,100 will return 102
  - all previous formats should also be supported
- Step 7: Support 1 custom delimiter of any length using the format: //[{delimiter}]\n{numbers}
  - example: //[***]\n11***22***33 will return 66
  - all previous formats should also be supported
- Step 8: Support multiple delimiters of any length using the format: //[{delimiter1}][{delimiter2}]...\n{numbers}
  - example: //[*][!!][r9r]\n11r9r22*hh*33!!44 will return 110
  - all previous formats should also be supported

