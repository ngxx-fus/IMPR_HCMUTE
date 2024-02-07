import numpy as np
from PIL import Image
import cv2
from func import gray_scale_lightness_PILLOW
from func import binary_image_PILLOW

image_path = r"D:\DOC\23-24_HK02\IMPR\ngxx_fus.jpg"

#open an image
original = Image.open( image_path )

gray = gray_scale_lightness_PILLOW(original)
cv2.imshow( "Gray", np.array(gray))

for threshold in (40, 70, 120, 145, 190):
    tmp = binary_image_PILLOW(gray, threshold)
    cv2.imshow( "threshold={}".format(threshold), np.array(tmp))

cv2.waitKey(0)
cv2.destroyAllWindows()


