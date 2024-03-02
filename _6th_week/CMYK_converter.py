import cv2
import numpy as np
from PIL import Image
from func import CMYK_splitter
from func import quick_show

#assign image path
img_path = r"D:\DOC\23-24_HK02\IMPR\PHAO_HOA.jpg"

#read image using PIL.Image 
img = Image.open( img_path ).convert("RGB")

C, M, Y, K = CMYK_splitter(img)
 
quick_show("C channel",  C)
quick_show("M channel",  M)
quick_show("Y channel",  Y)
quick_show("K channel",  K)

cv2.waitKey(0)
cv2.destroyAllWindows()

