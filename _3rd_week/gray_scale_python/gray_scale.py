import cv2          #sử dụng thư viện xử lí ảnh openCV cho python   
import numpy as np  #thư viện toán học
from PIL import Image
from func import gray_scale_avg_PILLOW
from func import  gray_scale_lightness_PILLOW
from func import gray_scale_luminance_PILLOW


# Lưu đường dẫn ảnh
# <r> for raw text
img_path = r"D:/DOC/23-24_HK02/IMPR/ngxx_fus.jpg"

#Đọc ảnh màu dùng thư viện PIL
original = Image.open(img_path).convert('RGB')

#Hiển thị hình gốc 
"""Vì PIL có cấu trúc xếp kênh là RGB, còn cv2 có cấu trúc xếp kênh là BGR, vì
vậy muốn hiển thị một ảnh màu RGB được lưu dưới dạng PIL.Image ta phải
chuyển đổi thứ tự kênh!"""


cv2.imshow("Original", cv2.cvtColor(np.array(original), cv2.COLOR_RGB2BGR ))

gray_average_method = gray_scale_avg_PILLOW(original)
gray_lightness_method = gray_scale_lightness_PILLOW(original)
gray_luminance_method = gray_scale_luminance_PILLOW(original)

cv2.imshow("Average method - Gray scale", np.array(gray_average_method))
cv2.imshow("Lightness method - Gray scale", np.array(gray_lightness_method))
cv2.imshow("Luminance method - Gray scale", np.array(gray_luminance_method))

#Giải phóng bộ nhớ
cv2.waitKey(0)
cv2.destroyAllWindows()
