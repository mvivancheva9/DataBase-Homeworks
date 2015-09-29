<?xml version="1.0" encoding="windows-1251"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students List Table</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" border="1">
          <tr bgcolor="#EEEEEE">
            <th>Student</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>E-mail</th>
            <th>Course</th>
            <th>Specialty</th>
            <th>Faculty #</th>
            <th>Exams</th>
          </tr>
          <xsl:for-each select="students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthDate"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="facultyNumber"/>
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <div>
                      <xsl:value-of select="examName"/>:
                    <br/>
                    tutor: <xsl:value-of select="tutor"/>
                   /
                    score: <xsl:value-of select="score"/>
                  </div>
                  <br/>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
  
</xsl:stylesheet>