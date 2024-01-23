import cv2          #sử dụng thư viện xử lí ảnh openCV cho python   
import numpy as np  #thư viện toán học
import sys

# Lưu đường dẫn ảnh
img_path = "D:\\DOC\\23-24_HK02\\IMPR\\789x480_IMG.jpg"
#Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(img_path, cv2.IMREAD_COLOR)


#Hiển thị hình dùng thư viện OPENCV
cv2.imshow('Image', img)

#Lấy kích thước ảnh gốc
#imp.shape trả về tuple(height, width, channel)

h, w = img.shape

print(h)
print(w)

#Tạo bức ảnh mới
Red = np.zeros((h, w, 3), np.uint8)
Green = np.zeros((h, w, 3), np.uint8)
Blue = np.zeros((h, w, 3), np.uint8)

#Tách kênh màu bằng cách duyệt các pixel trên hình gốc và tách ra ở 3 kênh
for x in range(w-1):
    for y in range(h-1):
        pixel = img[y,x]
        #pixel là 1 lát cắt dọc các lớp theo các kênh B G R tương ứng pixel[0] pixel[1] pixel[2]
        Red[y, x, 2] = pixel[2]
        Green[y, x, 1] = pixel[1]
        Blue[y, x, 0] = pixel[0]

#Hiển thị ảnh gốc và các kênh

cv2.imshow("Red", Red)

cv2.imshow("Green", Green)

cv2.imshow("Blue", Blue)

#Bấm phím để kết thúc   
cv2.waitKey(0)

#Giải phóng bộ nhớ
cv2.destroyAllWindows()
