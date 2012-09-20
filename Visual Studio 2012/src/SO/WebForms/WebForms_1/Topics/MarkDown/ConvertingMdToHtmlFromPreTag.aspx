<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertingMdToHtmlFromPreTag.aspx.cs" Inherits="WebForms_1.Topics.MarkDown.ConvertingMdToHtmlFromPreTag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Scripts/jquery-1.7.1.min.js"></script>
    <script src="../../Scripts/showdown.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script>
        $(function () {
            var $mds = $("pre.md");
            var $txt1 = $("#txt1");
            var $txt2 = $("#txt2");

            $txt1.scroll(function () {
                $txt2.scrollTop($txt1.scrollTop());
            });

            $txt2.scroll(function () {
                $txt1.scrollTop($txt2.scrollTop());
            });

            $mds.each(function (i, x) {
                var $pre = $(x);
                var preContent = this.innerHTML;
                var converter = new Showdown.converter();

                preContent = preContent.replace(/&gt;/g, ">");

                $txt1.val(preContent);
                $txt2.val(unescape(preContent));

                $pre.html("");
                $pre.html(converter.makeHtml(preContent));
            });

            $("#dd").click(function () {
                //$("table[id$=rdl] input:radio:checked").removeAttr("checked");

                $("table[id$=rdl] input:radio").each(function (i, x) {
                    if ($(x).is(":checked")) {
                        $(x).removeAttr("checked");
                    }
                });
            });
        });
    </script>
    <h1>
        Converting MD to HTML
    </h1>
    <h2>
        Reading a pre tag
    </h2>
    <table style="width:100%">
        <tr>
            <td style="width:50%">
                <input type="button" id="dd" value="Deselect" />
                <asp:RadioButtonList runat="server" ID="rdl">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:RadioButtonList>
    <textarea id="txt1" name="txt1" rows="5" cols="20" ></textarea>
    <br />
    <textarea id="txt2" name="txt2" rows="5" cols="20" ></textarea>
    <br />
    <pre class="md">
Using this tool
---------------

#dede#

**dede**

>dedede
>deniue duie duie deui

_dede_
[dede](http_//google.com)
![dede](http_//google.com)

dekdmekmdedmek
de
d
e
de

n

`dedededede`
     <dedede>
    dedeprotected void Page_Load(object sender, EventArgs e)
    {
     <dedede>
       this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }

de
<dede>
        protected void Page_Load(object sender, EventArgs e)
        {
         this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

```
             ndejndjendjendjenjdenjdenjdenjden
              de
d
e
de
d
plopprotected void Page_Load(object sender, EventArgs e)
{
   this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
}
```

This page lets you create HTML by entering text in a simple format that's easy to read and write.

  - Type Markdown text in the left window
  - See the HTML in the right

Markdown is a lightweight markup language based on the formatting conventions that people naturally use in email.  As [John Gruber] writes on the [Markdown site] [1]:

> The overriding design goal for Markdown's
> formatting syntax is to make it as readable 
> as possible. The idea is that a
> Markdown-formatted document should be
> publishable as-is, as plain text, without
> looking like it's been marked up with tags
> or formatting instructions.

This document is written in Markdown; you can see the plain-text version on the left.  To get a feel for Markdown's syntax, type some text into the left window and watch the results in the right.  You can see a Markdown syntax guide by switching the right-hand window from *Preview* to *Syntax Guide*.

Showdown is a Javascript port of Markdown.  You can get the full [source code] by clicking on the version number at the bottom of the page.

**Start with a [blank page] or edit this document in the left window.**

  [john gruber]: http://daringfireball.net/
  [1]: http://daringfireball.net/projects/markdown/
  [source code]: http://www.attacklab.net/showdown-v0.9.zip
  [blank page]: ?blank=1 "Clear all text"


## Syntax highlighting

When combined with [highlight.js][] this starts looking as a kind of IDE :-)

HTML:

    <h1>HTML code</h1>
    <p class="some">This is an example</p>

Python:

    def func():
      for i in [1, 2, 3]:
        print "%s" % i


[highlight.js]: http://softwaremaniacs.org/soft/highlight/en/
    </pre>
            </td>
            <td style="width:50%">
                de
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
