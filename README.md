# ForthCtags

This ctag configuration file will allow navigation into a Forth source file definitions.

The expression

    /:[ \t]+([^ \t]+)/\1/d,definitions/

denotes any colon definition in Forth: colon, followed by space and then a name. A name in Forth can include any non space character.

