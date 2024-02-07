from PIL import Image

img_path = r"D:/DOC/23-24_HK02/IMPR/ngxx_fus.jpg"

# Open the RGB image
img = Image.open(img_path)

# Convert it to grayscale
gray_img = img.convert('L')

gray_img.show()

