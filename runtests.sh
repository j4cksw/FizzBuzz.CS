rm *.dll
rm TestResult.xml
mcs fizzbuzz.cs *.cs -reference:nunit.framework.dll -target:library
NUNIT-CONSOLE fizzbuzz.dll
