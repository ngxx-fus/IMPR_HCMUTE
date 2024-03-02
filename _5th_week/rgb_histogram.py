import matplotlib.pyplot as plt
import cv2
import numpy as np
from PIL import Image
from func import get_histogram

#path to img
img_path = r"D:\DOC\23-24_HK02\IMPR\bird_small.jpg"
#open with PIL.Image
img = Image.open(img_path).convert("RGB")
#Get histogram
histogram = get_histogram(Img=img)
#Show original image
cv2.imshow("Gray", cv2.cvtColor(np.array(img), cv2.COLOR_RGB2BGR))
#plot the histogram into a figure
plt.figure("Histogram", figsize=(6, 4),dpi=100 )
value_axis = np.linspace(0, 255, 256)
plt.xlabel("Value")
plt.ylabel("Frequency")
plt.title("Histogram")
plt.plot(value_axis, histogram[0], color="red")
plt.plot(value_axis, histogram[1], color="green")
plt.plot(value_axis, histogram[2], color="blue")
plt.show()

