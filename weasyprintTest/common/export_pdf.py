from weasyprint import HTML

def makepdf(html_file_path):
    with open(html_file_path, 'r', encoding='utf-8') as html_file:
        html = html_file.read()

    htmldoc = HTML(string=html, base_url="")
    return htmldoc.write_pdf()

def test(path):
    pdf_data = makepdf(path)
    pdf_path = 'D:/output.pdf'

    
    with open(pdf_path, 'wb') as f:
        f.write(pdf_data)
