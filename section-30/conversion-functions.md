conversion functions


**Conversion functions**
can use iether on of these funcs to convert data types from one to another

- CONVERT()
- CAST()



**CONVERT() syntax** - convert function returns the val of expression translated into the target type with specefied style
- data type param is required. The datatype to convert expression can be one of the folloing
   - bigint, int, smallint, tinyin, bit, varchar, float datetime.

- length is optional. The length of the resulting data type (for char, varchar, nchar, nvarchar, binary and varbinary)
- Expression, param is required, the value to convert to another datatype
- style param is optional. used to convert between data types, such as date or string format.
--------------------------------------------------------------
CONVERT(DataType(Length), Expression, Style)
-- 3 params: data type, expression, and style
--------------------------------------------------------------



**CAST() syntax** - cast func returns val of exprression that will be translated to the target type with a specified style
- expression is required. The value to convert another data type to
- data type param is required. The datatype to convert expression can be one of the folloing
   - bigint, int, smallint, tinyin, bit, varchar, float datetime.
- length is optional. The length of the resulting data type (for char, varchar, nchar, nvarchar, binary and varbinary)
--------------------------------------------------------------
CAST(Expression AS DataType(Length))
-- takes 2 params: expression and datatype

--------------------------------------------------------------

stopped at **3:25**