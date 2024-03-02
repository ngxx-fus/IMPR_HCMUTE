import matplotlib.pyplot as plt
import cv2
import numpy as np
from PIL import Image
from func import get_histogram
from func import gray_scale_luminance_PILLOW

#path to img
img_path = r"D:\DOC\23-24_HK02\IMPR\ngxx_fus.jpg"
#open with PIL.Image
img = Image.open(img_path).convert("RGB")
#Gray-scale
gray = gray_scale_luminance_PILLOW(img)
#Get histogram
histogram = get_histogram(gray)

#Display image and histogram of image
cv2.imshow("Gray", cv2.cvtColor(np.array(gray), cv2.COLOR_RGB2BGR))
plt.figure("Histogram", figsize=(3,3),dpi=100 )
X_axis = np.linspace(0, 255, 256)
plt.xlabel("Giá trị")
plt.ylabel("Tuần suất xuất hiện")
plt.title("Histogram")
plt.plot(X_axis, histogram, color="blue")
# 
plt.draw()
plt.show()





