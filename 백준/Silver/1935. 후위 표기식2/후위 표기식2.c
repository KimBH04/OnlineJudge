#include <stdio.h>
#include <stdlib.h>

typedef struct node {
    double data;
    struct node *prev;
} node;

typedef struct stack {
    unsigned int size;
    node *top;
} stack;

void push(stack *stack, double data) {
    if (stack->top == NULL) {
        stack->top = (node*)malloc(sizeof(node));
        stack->top->data = data;
        stack->top->prev = stack->top;
    }
    else {
        node *new = (node*)malloc(sizeof(node));
        new->data = data;
        new->prev = stack->top;
        stack->top = new;
    }
    stack->size++;
}

void pop(stack *stack) {
    if (stack->size == 0) {
        return;
    }

    node *top = stack->top;
    stack->top = stack->top->prev;
    free(top);
    stack->size--;

    if (stack->size == 0) {
        stack->top = NULL;
    }
}

double top(stack *stack) {
    return stack->top->data;
}

void release(stack *stack) {
    while (stack->size > 0) {
        pop(stack);
    }
    free(stack);
}

int main() {
    int n, var[26];
    char query[101];
    scanf("%d %s", &n, query);

    for (int i = 0; i < n; i++) {
        scanf("%d", var + i);
    }

    double a, b;
    stack *s = (stack*)malloc(sizeof(stack));
    for (int i = 0; query[i] != '\0'; i++) {
        switch (query[i])
        {
        case '+':
            a = top(s); pop(s);
            b = top(s); pop(s);
            push(s, b + a);
            break;

        case '-':
            a = top(s); pop(s);
            b = top(s); pop(s);
            push(s, b - a);
            break;
            
        case '*':
            a = top(s); pop(s);
            b = top(s); pop(s);
            push(s, b * a);
            break;
            
        case '/':
            a = top(s); pop(s);
            b = top(s); pop(s);
            push(s, b / a);
            break;

        default:
            push(s, var[query[i] - 65]);
            break;
        }
    }
    printf("%.2f", top(s));

    release(s);
    return 0;
}