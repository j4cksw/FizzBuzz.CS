rm *.dll
rm TestResult.xml
mcs FizzBuzz.cs *.cs -reference:nunit.framework.dll -target:library
NUNIT-CONSOLE fizzbuzz.dll
