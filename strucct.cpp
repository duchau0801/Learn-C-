#include <stdio.h>
#include <string.h>

#define MAX_CONTACTS 2000

// Khai bao cau truc lien he
struct Contact {
    char name[50];
    char phone[20];
    char email[60];
};

// Mang de luu tru danh sach lien he
struct Contact contacts[MAX_CONTACTS];

// Bien dem so luong lien he hien tai
int numContacts = 0;

// Ham them lien he moi
void add_contact() {
    if (numContacts < MAX_CONTACTS) {
        printf("Nhap ten lien he: ");
        scanf("%s", contacts[numContacts].name);
        printf("Nhap so dien thoai: ");
        scanf("%s", contacts[numContacts].phone);
        numContacts++;
        printf("Nhap dia chi email: ");
        scanf("%s",contacts[numContacts].email);
        printf("Lien he da duoc them thanh cong!\n");
    } else {
        printf("Danh ba da day, khong the them lien he moi!\n");
    }
}

// Hàm de tim kiem lien he
void search_contact() {
    char searchName[50];
    printf("Nhap ten lien he can tim: ");
    scanf("%s", searchName);
    
    int found = 0;
    for (int i = 0; i < numContacts; i++) {
        if (strcmp(contacts[i].name, searchName) == 0) {
            printf("So dien thoai cua %s là: %s\n", searchName, contacts[i].phone);
            found = 1;
            break;
        }
    }
    if (!found) {
        printf("Khong tim thay lien he danh ba!\n");
    }
}

// Ham de xoa lien he
void delete_contact() {
    char deleteName[50];
    printf("Nhap ten lien he can xoa: ");
    scanf("%s", deleteName);
    
    int found = 0;
    for (int i = 0; i < numContacts; i++) {
        if (strcmp(contacts[i].name, deleteName) == 0) {
            for (int j = i; j < numContacts - 1; j++) {
                strcpy(contacts[j].name, contacts[j+1].name);
                strcpy(contacts[j].phone, contacts[j+1].phone);
            }
            numContacts--;
            printf("Lien he da duoc xoa thanh cong!\n");
            found = 1;
            break;
        }
    }
    if (!found) {
        printf("Khong tim thay lien he trong danh ba!\n");
    }
}

// Ham de hien thi danh sach lien he
void list_contacts() {
    if (numContacts > 0) {
        printf("Danh ba cua ban:\n");
        for (int i = 0; i < numContacts; i++) {
            printf("%s: %s\n", contacts[i].name, contacts[i].phone);
        }
    } else {
        printf("Danh ba cua ban dang trong!\n");
    }
}

int main() {
    int choice;
    while (1) {
        printf("\nMenu:\n");
        printf("1. Them lien he\n");
        printf("2. Tim kiem lien he\n");
        printf("3. Xoa lien he\n");
        printf("4. Hien thi danh ba \n");
        printf("5. Thoat\n");
        printf("Chon chuc nang (1/2/3/4/5): ");
        scanf("%d", &choice);
        
        switch (choice) {
            case 1:
                add_contact();
                break;
            case 2:
                search_contact();
                break;
            case 3:
                delete_contact();
                break;
            case 4:
                list_contacts();
                break;
            case 5:
                printf("Cam on ban da su dung chuong trinh!\n");
                return 0;
            default:
                printf("Chuc nang khong hop le. Vui long chon lai.\n");
        }
    }
    return 0;
}

